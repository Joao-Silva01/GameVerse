import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.jsx'
import { createBrowserRouter, RouterProvider } from 'react-router-dom'
import GameList from './Components/GameList.jsx'
import { Game } from './Components/Game.jsx'

const router = createBrowserRouter([
  {
    path : "/",
    element: <App/>
  },
  {
    path : "/GameList",
    element: <GameList/>
  },
  {
    path : "/Game",
    element: <Game />
  }
])


createRoot(document.getElementById('root')).render(
  <StrictMode>
    <RouterProvider router={router} />
  </StrictMode>,
)
