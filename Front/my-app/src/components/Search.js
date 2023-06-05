import React, { useState } from 'react';
import axios from 'axios';
import Card from './Card';

function Search() {
    const [query, setQuery] = useState('');
    const [results, setResults] = useState([]);

    const handleInputChange = (event) => {
        setQuery(event.target.value);
    };

    const handleSubmit = (event) => {
        event.preventDefault();
        searchAPI();
    };
    const searchAPI = async () => {
        try {
            //   const response = await axios.get(``); //add API key
            let tmpResults = [{ img: 'https://media.istockphoto.com/id/488580536/photo/giraffe-in-front-of-kilimanjaro-mountain.jpg?s=612x612&w=0&k=20&c=xqZ1Lo6_a1Lq4JwRFTts6xCGI0NxMI4UuAYXM5Qwk8g=' },
            { img: 'https://media.istockphoto.com/id/488580536/photo/giraffe-in-front-of-kilimanjaro-mountain.jpg?s=612x612&w=0&k=20&c=xqZ1Lo6_a1Lq4JwRFTts6xCGI0NxMI4UuAYXM5Qwk8g=' },
            { img: 'https://media.istockphoto.com/id/488580536/photo/giraffe-in-front-of-kilimanjaro-mountain.jpg?s=612x612&w=0&k=20&c=xqZ1Lo6_a1Lq4JwRFTts6xCGI0NxMI4UuAYXM5Qwk8g=' },]
            setResults(tmpResults);
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
                    <Card imageUrl={result.img} title={'AnimalName'}></Card>
                ))}
            </ul>
        </div>
    );
};

export default Search; 
{/* <div className='resultCard'>
    <img src={result.img} key={index}></img>
    <p className='cardTitle'>AnimalName</p>
</div> */}