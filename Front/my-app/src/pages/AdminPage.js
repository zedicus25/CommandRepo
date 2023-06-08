import React from "react";
import '../css/Admin.css'
import axios from "axios";
import { Outlet, useNavigate} from "react-router-dom";

function AdminPage() {

    const navigate = useNavigate();


    return (
        <div className="admin-page">
            <h1>Wildlife Admin</h1>
            <div className="admin-main">
                <div className="admin-panel">
                    <div className="admin-sidebar">
                        <ul>
                            <li><p>Kingdoms</p>
                                <div className="dropdown-content">
                                    <button onClick={() => navigate('kingdom/add')}>Add</button>
                                    <button onClick={() => navigate('kingdom/edit')}>Edit</button>
                                    <button onClick={() => navigate('kingdom/remove')}>Remove</button>
                                </div></li>
                            <li><p>Classes</p>
                                <div className="dropdown-content">
                                    <button onClick={() => navigate('class/add')}>Add</button>
                                    <button onClick={() => navigate('class/edit')}>Edit</button>
                                    <button onClick={() => navigate('class/remove')}>Remove</button>
                                </div></li>
                            <li><p>Families</p>
                                <div className="dropdown-content">
                                    <button onClick={() => navigate('family/add')}>Add</button>
                                    <button onClick={() => navigate('family/edit')}>Edit</button>
                                    <button onClick={() => navigate('family/remove')}>Remove</button>
                                </div></li>
                            <li><p>Genuses</p>
                                <div className="dropdown-content">
                                    <button onClick={() => navigate('genus/add')}>Add</button>
                                    <button onClick={() => navigate('genus/edit')}>Edit</button>
                                    <button onClick={() => navigate('genus/remove')}>Remove</button>
                                </div></li>
                            <li><p>Species</p>
                                <div className="dropdown-content">
                                    <button onClick={() => navigate('species/add')}>Add</button>
                                    <button onClick={() => navigate('species/edit')}>Edit</button>
                                    <button onClick={() => navigate('species/remove')}>Remove</button>
                                </div></li>
                        </ul>
                    </div>
                    <Outlet></Outlet>
                </div>
                
            </div>
        </div>
    );
}

export default AdminPage;