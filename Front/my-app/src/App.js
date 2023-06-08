import logo from './logo.svg';
import './css/App.css';
import { Routes, Route} from 'react-router-dom'
import MainPage from "./pages/MainPage.js";
import AdminPage from './pages/AdminPage'
import SpeciesPage from './pages/SpeciesPage';
import { useParams } from 'react-router-dom';
import SpeciesAdmin from './components/AdminComponents/SpeciesAdmin';
import CategoriesAdmin from './components/AdminComponents/CategoriesAdmin';

function App() {
	return (
		
				<Routes>
					<Route path="/" element={<MainPage/>}/>
					<Route path='/species/:id' element={<SpeciesPage/>}/>
					<Route path='/admin' element={<AdminPage/>}>
						<Route index element={<SpeciesAdmin/>}></Route>
						<Route path=':category/:action' element={<CategoriesAdmin/>}></Route>
					</Route>
				</Routes>
		
	);
}

export default App;
