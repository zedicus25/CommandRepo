import React from 'react';

function Card({imageUrl, title}) {
    return (
        <div className="card">
            <img src={imageUrl} alt={title} className="cardImage" />
            <div className="cardContent">
                <h2 className="cardTitle">{title}</h2>
            </div>
        </div>
    );
}

export default Card;