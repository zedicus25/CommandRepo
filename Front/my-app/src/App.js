import logo from './logo.svg';
import './App.css';
import Search from './components/Search';
import SideBar from './components/SideBar';

function App() {
	return (
		<div className="App">
			<div className="header">
				<h1>Wildlife Guide</h1>
			</div>
			<div className='main'>
				<SideBar></SideBar>
				<div className="content">
					<Search></Search>
				</div>
			</div>
		</div>
	);
}

export default App;
