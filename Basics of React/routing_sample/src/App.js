import logo from './logo.svg';
import './App.css';
import HomePage from './pages/HomePage';
import AboutPage from './pages/AboutPage';
import NavBar from './components/NavBar';
import { BrowserRouter, Routes, Route } from 'react-router-dom';

function App() {
  return (
    <>
    
    <BrowserRouter>
    <NavBar/>
    <Routes>
      <Route path = "/"element = {<HomePage/>}/>
      <Route path = "/about"element = {<AboutPage/>}/>
    </Routes>
    </BrowserRouter>
    

    </>
  );
}

export default App;
