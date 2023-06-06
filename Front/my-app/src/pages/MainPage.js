import React from "react";
import Search from "../components/Search";
import '../css/Main.css'

function MainPage() {
	return (
		<div className="main-page">
			<div className="header">
				<h1>Wildlife Guide</h1>
			</div>
			<div className='main'>
				<div className="sidebar">
					<ul>
						<li>Kingdom</li>
						<li>Subspecies</li>
					</ul>
				</div>
				<div className="content">
					<Search></Search>
				</div>
			</div>
		</div>
	);
}

export default MainPage;