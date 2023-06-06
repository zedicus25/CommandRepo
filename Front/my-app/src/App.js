import logo from './logo.svg';
import './css/App.css';
import { Routes, Route} from 'react-router-dom'
import MainPage from "./pages/MainPage.js";
import AdminPage from './pages/AdminPage'
import SpeciesPage from './pages/SpeciesPage';
import { useParams } from 'react-router-dom';

function App() {
	return (
		
				<Routes>
					<Route path="/" element={<MainPage/>}/>
					<Route path='/admin' element={<AdminPage/>}/>
					<Route path='/species/:id' element={<SpeciesPage/>}/>
				</Routes>
		
	);
}

export default App;
