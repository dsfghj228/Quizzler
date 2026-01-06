import { BrowserRouter, Route, Routes } from "react-router-dom";
import Home from "./pages/Home";
import Login from "./pages/Login";
import Question from "./pages/Question";
import Register from "./pages/Register";
import Start from "./pages/Start";
import AuthProtectedRoute from "./routes/AuthProtectedRoute";
import ProtectedRoute from "./routes/ProtectedRoute";

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Home />} />

        <Route element={<AuthProtectedRoute />}>
          <Route path="/login" element={<Login />} />
          <Route path="/register" element={<Register />} />
        </Route>

        <Route element={<ProtectedRoute />}>
          <Route path="/quiz/start" element={<Start />} />
          <Route path="/quiz/:sessionId" element={<Question />} />
        </Route>
      </Routes>
    </BrowserRouter>
  );
}

export default App;
