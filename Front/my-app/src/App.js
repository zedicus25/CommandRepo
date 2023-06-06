import logo from './logo.svg';
import './App.css';
import { Routes, Route} from 'react-router-dom'
import MainPage from "./pages/MainPage.js";
import AdminPage from './pages/AdminPage'

function App() {
	return (
		
				<Routes>
					<Route path="/" element={<MainPage/>} />
					<Route path='/admin' element={<AdminPage/>}></Route>
				</Routes>
		
	);
}

export default App;
