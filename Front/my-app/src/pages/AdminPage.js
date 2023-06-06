import React from "react";
import '../Admin.css'

function AdminPage() {
    return (
        <div className="admin-page">
            <h1>Wildlife Admin</h1>
            <div className="admin-main">
                <div className="admin-panel">
                    <div className="admin-sidebar">
                        <ul>
                            <li><p>Kingdoms</p>
                                <div className="dropdown-content">
                                    <button>Add</button>
                                    <button>Edit</button>
                                </div></li>
                            <li><p>Classes</p>
                                <div className="dropdown-content">
                                    <button>Add</button>
                                    <button>Edit</button>
                                </div></li>
                            <li><p>Families</p>
                                <div className="dropdown-content">
                                    <button>Add</button>
                                    <button>Edit</button>
                                </div></li>
                            <li><p>Genes</p>
                                <div className="dropdown-content">
                                    <button>Add</button>
                                    <button>Edit</button>
                                </div></li>
                            <li><p>Species</p>
                                <div className="dropdown-content">
                                    <button>Add</button>
                                    <button>Edit</button>
                                </div></li>
                        </ul>
                    </div>
                    <div className="inputs">
                        <div className="main-inputs">
                            <ul>
                                <li>
                                    <label>Input Name:</label>
                                    <input type="text"></input>
                                </li>
                                <li>
                                    <label>Input Description:</label>
                                    <input type="text"></input>
                                </li>
                                <li>
                                    <label>Image URL:</label>
                                    <input type="text"></input>
                                </li>

                            </ul>
                        </div>
                        <div className="category-inputs">
                            <ul>
                                <li>
                                    <label>Kingdom:</label>
                                    <form action="">
                                        <select>

                                        </select>
                                    </form>
                                </li>
                                <li>
                                    <label>Gene:</label>
                                    <form action="">
                                        <select>

                                        </select>
                                    </form>
                                </li>
                                <li>
                                    <label>Class:</label>
                                    <form action="">
                                        <select>

                                        </select>
                                    </form>
                                </li>
                                <li>
                                    <label>Family:</label>
                                    <form action="">
                                        <select>

                                        </select>
                                    </form>
                                </li>
                            </ul>
                        </div>

                    </div>
                </div>
                <button className="confirm-button">Confirm</button>
            </div>
        </div>
    );
}

export default AdminPage;