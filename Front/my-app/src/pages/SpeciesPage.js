import React, { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import '../css/Species.css'
import { useNavigate } from "react-router-dom";


function SpeciesPage() {
    const navigate = useNavigate();

    let { id } = useParams();

    const [name, setName] = useState('speciesName');
    const [kingdom, setKingdom] = useState('kingdom');
    const [family, setFamily] = useState('family');
    const [imgUrl, setImgUrl] = useState('https://media.istockphoto.com/id/488580536/photo/giraffe-in-front-of-kilimanjaro-mountain.jpg?s=612x612&w=0&k=20&c=xqZ1Lo6_a1Lq4JwRFTts6xCGI0NxMI4UuAYXM5Qwk8g=');
    const [specieClass, setSpecieClass] = useState('class');
    const [gene, setGene] = useState('gene');

    useEffect(() => {
        //API call here
    }, []);
    return (
        <div className="species-page">
            <div className="header" onClick={() => navigate("/")}>
                <h1>Wildlife Guide</h1>
            </div>
            <div className="specie-block">
                <div className="description">
                    <h1>Animal Name</h1>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in ullamcorper risus. Curabitur cursus velit vitae neque varius pharetra. Proin ante lorem, dictum eget facilisis vitae, accumsan id tortor. Maecenas interdum nunc urna, vitae venenatis enim cursus sit amet. Praesent in pellentesque est. Praesent scelerisque aliquet enim, nec mattis lectus sollicitudin ut. Nulla a sollicitudin arcu, et sodales nisl. Nunc ac tempus eros, nec convallis quam. Nulla quis enim ac lorem viverra eleifend. Vivamus faucibus eros ut sem malesuada condimentum. Vestibulum interdum lacus ut tempus scelerisque. Proin id maximus ipsum. Nulla sed bibendum eros. </p>
                </div>
                <div className="info">
                    <img src={imgUrl} alt={name}/>
                    <ul>
                        <li>Family: {family}</li>
                        <li>Class: {specieClass}</li>
                        <li>Gene: {gene}</li>
                        <li>Kingdom: {kingdom}</li>
                    </ul>
                </div>
            </div>
        </div>
    );
}

export default SpeciesPage;