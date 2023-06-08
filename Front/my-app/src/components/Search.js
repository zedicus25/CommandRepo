import React, { useState } from 'react';
import axios from 'axios';
import Card from './Card';

function Search() {
    const [query, setQuery] = useState('');
    const [results, setResults] = useState([]);

    function handleInputChange (event) {
        setQuery(event.target.value);
    };

    function handleSubmit (event) {
        event.preventDefault();
        searchAPI();
    };
    async function searchAPI() {
        try {
            const response = await axios.get(`https://localhost:7132/api/Species/SelectAnimal?search=${query}`); 
            setResults(response.data);
        } catch (error) {
            console.error(error);
        }
    };


    return (
        <div className='search'>
            <form onSubmit={handleSubmit}>
                <input className='searchInput' type="text" value={query} onChange={handleInputChange} placeholder="Search Animal" />
                <button className='searchButton' type="submit">
                <svg xmlns="http://www.w3.org/2000/svg" width="30" height="30" fill="currentColor" class="bi bi-search" viewBox="0 0 16 16"> <path d="M11.742 10.344a6.5 6.5 0 1 0-1.397 1.398h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.007 1.007 0 0 0-.115-.1zM12 6.5a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0z"/> </svg>                 </button>
            </form>
            <ul className='results'>
                {results.map((result, index) => ( 
                    <Card key={index} imageUrl={result.image} title={result.name} id={result.id}></Card>
                ))}
            </ul>
        </div>
    );
};

export default Search; 
