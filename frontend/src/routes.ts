import Home from "./components/pages/Home";
import Vehicles from "./components/pages/Vehicles";

interface Route {
  id: number;
  name: string;
  path: string;
  component?: () => JSX.Element;
}

const routes: Route[] = [
  {
    id: 0,
    name: "Início",
    path: "/",
    component: Home,
  },
  {
    id: 1,
    name: "Veículos",
    path: "/vehicles",
    component: Vehicles,
  },
];

export default routes;
