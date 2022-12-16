import logo from './logo.svg';
import './App.css';

import{Home} from './Home'
import{Student} from './Student'
import{UniTasks} from './UniTasks'
import{Navigation} from './Navigation'

import{BrowserRouter as Router, Route, Link, Routes} from 'react-router-dom'


function App() {
  return (
  
      <Router>
  
        <Navigation/>
  
        <Routes>
            <Route path = '/' element ={<Home/>} exact></Route>
            <Route path = '/Student' element ={<Student/>} exact></Route>
            <Route path = '/UniTasks' element ={<UniTasks/>} exact></Route>
        </Routes>
  
  
      </Router>
  
  
    );
}

export default App;
