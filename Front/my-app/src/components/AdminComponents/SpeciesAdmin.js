import React from "react";
import { useState, useEffect } from "react";
import axios from "axios";

function SpeciesAdmin() {
    const [kingdoms, setKingdoms] = useState([{ id: 1, name: "loading..." }]);
    const [genuses, setGenuses] = useState([{ id: 1, name: "loading..." }]);
    const [classes, setClasses] = useState([{ id: 1, name: "loading..." }]);
    const [families, setFamilies] = useState([{ id: 1, name: "loading..." }]);

    const [kingdomId, setKingdomId] = useState(1);
    const [genusId, setGenusId] = useState(1);
    const [classId, setClassId] = useState(1);
    const [familyId, setFamilyId] = useState(1);
    const [name, setName] = useState("");
    const [desc, setDesc] = useState("");
    const [imgUrl, setImgUrl] = useState("");

    useEffect(() => {
        let api = "http://fowon21908-001-site1.ctempurl.com/api";
        try {
            axios.get(api + "/Kingdom/Select").then(res => {setKingdoms(res.data); setKingdomId(res.data[0].id)});
            axios.get(api + "/Gen/Select").then(res =>{ setGenuses(res.data); setGenusId(res.data[0].id)});
            axios.get(api + "/Class/Select").then(res => {setClasses(res.data); setClassId(res.data[0].id)});
            axios.get(api + "/Family/Select").then(res => {setFamilies(res.data); setFamilyId(res.data[0].id)});
            
            
        } catch (error) { console.log(error); }

    }, []);

    function handleAdding() {
        if (name.trim() === "" || desc.trim() === "" || imgUrl.trim() === "") return;

        const config =
        {
            // http://fowon21908-001-site1.ctempurl.com/api/
            url: "http://fowon21908-001-site1.ctempurl.com/api/Species/Add",
            method: "POST",
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            data:
            {
                name: name,
                description: desc,
                image: imgUrl,
                idKingdom: kingdomId,
                idClass: classId,
                idFamily: familyId,
                idGen: genusId
            }
        };
        console.log(config);
        axios(config).then(() => alert(`${name} added`));

    }

    return (
        <div>
            <div className="inputs">
                <div className="main-inputs">
                    <ul>
                        <li>
                            <label>Input Name:</label>
                            <input value={name} onChange={e => setName(e.target.value)} type="text"></input>
                        </li>
                        <li>
                            <label>Input Description:</label>
                            <input value={desc} onChange={e => setDesc(e.target.value)} type="text"></input>
                        </li>
                        <li>
                            <label>Image URL:</label>
                            <input value={imgUrl} onChange={e => setImgUrl(e.target.value)} type="text"></input>
                        </li>

                    </ul>
                </div>
                <div className="category-inputs">
                    <ul>
                        <li>
                            <label>Kingdom:</label>
                            <select value={kingdomId} onChange={e => setKingdomId(e.target.value)}>
                                {kingdoms.map((item, index) =>
                                    <option key={item.id} value={item.id}>{item.name}</option>
                                )}
                            </select>
                        </li>
                        <li>
                            <label>Genus:</label>
                            <select value={genusId} onChange={e => setGenusId(e.target.value)}>
                                {genuses.map((item, index) =>
                                    <option key={item.id} value={item.id}>{item.name}</option>
                                )}
                            </select>
                        </li>
                        <li>
                            <label>Class:</label>
                            <select value={classId} onChange={e => setClassId(e.target.value)}>
                                {classes.map((item, index) =>
                                    <option key={item.id} value={item.id}>{item.name}</option>
                                )}
                            </select>
                        </li>
                        <li>
                            <label>Family:</label>
                            <select value={familyId} onChange={e => setFamilyId(e.target.value)}>
                                {families.map((item, index) =>
                                    <option key={item.id} value={item.id}>{item.name}</option>
                                )}
                            </select>
                        </li>
                    </ul>
                </div>
            </div>
                <button onClick={() => handleAdding()} className="confirm-button">Confirm</button>
        </div>
    );
}

export default SpeciesAdmin;