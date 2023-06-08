import React from 'react';
import { useNavigate } from 'react-router-dom';

function Card({imageUrl, title, id}) {
    const navigate = useNavigate()

    function handleClick()
    {
        navigate(`/species/${id}`);
    }
    return (
        <div className="card" onClick={() => handleClick()}>
            <img src={imageUrl} alt={title} className="cardImage" />
            <div className="cardContent">
                <h2 className="cardTitle">{title}</h2>
            </div>
        </div>
    );
}

export default Card;