import React, { useState, useEffect } from "react";
import { act } from "react-dom/test-utils";
import { useParams, useNavigate } from "react-router-dom";
import axios from "axios";



function CategoriesAdmin() {
    const navigate = useNavigate()

    let { category } = useParams();
    let { action } = useParams();

    const [name, setName] = useState("");
    const [showName, setShowName] = useState(false);

    const [id, setId] = useState(1);

    const [list, setList] = useState([{id:1, name:"loading..."}]);
    const [showList, setShowList] = useState(false);

    useEffect(() =>
    {
        setShowName(false);
        setShowList(false);
        action = action.charAt(0).toUpperCase() + action.slice(1).toLowerCase();
        if(action === "Add" || action === "Edit") setShowName(true);
        if(action === "Edit" || action === "Remove") setShowList(true);
        loadList();
        if(getApiCategoryName() === "Species" && action === "Add") navigate("/admin");
    }, [action, category]);

    function loadList()
    {
        setList([]);
        axios({
            url: `http://fowon21908-001-site1.ctempurl.com/api/${getApiCategoryName()}/Select`,
            method: "GET"
        }).then(res => {setList(res.data)});
    }

    function getApiCategoryName()
    {
        
        switch (category.toLowerCase()) {
            case "kingdom": return "Kingdom"
            case "class": return "Class";
            case "family": return "Family";
            case "genus": return "Gen";
            case "species": return "Species";
            default: return null;
        }
    }

    function handleCrud() 
    {
        action = action.charAt(0).toUpperCase() + action.slice(1).toLowerCase();
        let url = `http://fowon21908-001-site1.ctempurl.com/api/${getApiCategoryName()}/${action}`;
        let data = {};
        switch (action.toLowerCase()) {
            case "add":
                if(name.trim() == "") return;
                data = {name: name};
                break;
            case "edit":
                url = url.concat(`?id=${id}&newName=${name}`);
                break;
            case "remove":
                url = url.concat(`?id=${id}`);
                break;
            default:
                console.log(url, action);
                return;
        }
        try {
            axios({
                url: url,
                method: "POST",
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json; charset=utf-8'
                },
                data: data
            }).then(() => loadList()).catch(err => (action.toLowerCase()=="remove") ? alert(`Remove species with this ${category} first`) : console.log(err));
            
        } catch (error) {  console.log(error);}
    }

    return (
        <div className="inputs">
            <div className="category-crud">
                <h2>{action} {category}</h2>
                <ul>
                    <li style={{ display: (showList) ? "" : "none" }}>
                        <select value={id} onChange={(e) => setId(parseInt(e.target.value))}>
                            {list.map((element) =>(
                                <option value={element.id} key={element.name}>{element.name}</option>
                            ))}
                        </select>
                    </li>
                    <li style={{ display: (showName) ? "" : "none" }}>
                        <label>Name: </label>
                        <input value={name} onChange={(e) => setName(e.target.value)}></input>
                    </li>
                </ul>
                <button onClick={() => handleCrud()} className="category-crud-button">{action}</button>
            </div>
        </div>
    );
}

export default CategoriesAdmin;