import Layout from "./components/layout/Layout";

import { BrowserRouter as Router } from "react-router-dom";

export interface IAppProps {}

function App() {
  return (
    <>
      <Router>
        <Layout />
      </Router>
    </>
  );
}

export default App;
