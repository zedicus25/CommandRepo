import React, { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import '../css/Species.css'
import { useNavigate } from "react-router-dom";
import axios from "axios";


function SpeciesPage() {
    const navigate = useNavigate();

    let { id } = useParams();

    const [name, setName] = useState('');
    const [kingdom, setKingdom] = useState('');
    const [family, setFamily] = useState('');
    const [imgUrl, setImgUrl] = useState('');
    const [specieClass, setSpecieClass] = useState('');
    const [genus, setGenus] = useState('');
    const [desc, setDesc] = useState('');

    useEffect(() => {
        axios.get(`http://fowon21908-001-site1.ctempurl.com/api/Species/SelectAnimalById?id=${id}`)
        .then(res =>{
          const species = res.data;
          console.log(species);  
          setName(species.name);
          setKingdom(species.kingdom);
          setFamily(species.family);
          setImgUrl(species.image);
          setGenus(species.gen);
          setSpecieClass(species.cls);
          setDesc(species.description);
          console.log(species.name);
        })
    }, []);
    return (
        <div className="species-page">
            <div className="header" onClick={() => navigate("/")}>
                <h1>Wildlife Guide</h1>
            </div>
            <div className="specie-block">
                <div className="description">
                    <h1>{name}</h1>
                    <p>{desc}</p>
                </div>
                <div className="info">
                    <img src={`${imgUrl}`} alt={name}/>
                    <ul>
                        <li>Family: {family}</li>
                        <li>Class: {specieClass}</li>
                        <li>Gene: {genus}</li>
                        <li>Kingdom: {kingdom}</li>
                    </ul>
                </div>
            </div>
        </div>
    );
}

export default SpeciesPage;