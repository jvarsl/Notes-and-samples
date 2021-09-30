import Header from './components/Header'
import Tasks from './components/Tasks'
import { useState, useEffect } from 'react'
import AddTask from './components/AddTask'
import Footer from './components/Footer'
import About from './components/About'
import { BrowserRouter as Router, Route } from 'react-router-dom'

function App() {
  const [showAddTask, setShowAddTask] = useState(false);

  const [tasks, setTasks] = useState([]);

  useEffect(() => {
    const getTasks = async () => {
      const tasksFromApi = await fetchTasks();
      setTasks(tasksFromApi)
    };

    getTasks();
  }, [])

  const fetchTasks = async () => {
    const res = await fetch('https://localhost:44301/api/remindertasks');
    const data = await res.json();

    return data;
  }

  const fetchTask = async (id) => {
    const res = await fetch(`https://localhost:44301/api/remindertasks/${id}`);
    const data = await res.json();

    return data;
  }

  const addTask = async (task) => {
    const res = await fetch('https://localhost:44301/api/remindertasks',
      {
        method: 'POST',
        headers: {
          'Content-type': 'application/json'
        },
        body: JSON.stringify(task)
      });

    const data = await res.json();

    setTasks([...tasks, data]);
  }

  const deleteTask = async (id) => {
    await fetch(`https://localhost:44301/api/remindertasks/${id}`, { method: 'DELETE' })
    setTasks(tasks.filter((task) => task.id !== id));
  }

  const toggleReminder = async (id) => {
    const taskToToggle = await fetchTask(id);
    const updatedTask = { ...taskToToggle, reminder: !taskToToggle.reminder };

    await fetch(`https://localhost:44301/api/remindertasks/${id}`, {
      method: 'PUT',
      headers: {
        'Content-type': 'application/json'
      },
      body: JSON.stringify(updatedTask)
    });

    setTasks(tasks.map((task) => task.id === id ? { ...task, reminder: !task.reminder } : task));
  }

  return (
    <Router>
      <div className='container'>
        <Header onAdd={() => setShowAddTask(!showAddTask)} showAdd={showAddTask} />
        <Route path='/' exact render={(props) => (
          <>
            {showAddTask ? <AddTask onAdd={addTask} /> : ''}
            {tasks.length > 0 ?
              <Tasks tasks={tasks} onDelete={deleteTask} onToggle={toggleReminder} />
              : 'No Tasks To Show'}
          </>
        )} />
        <Route path='/about' component={About} />
        <Footer />
      </div>
    </Router>
  );
}

export default App;
