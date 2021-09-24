import { Container } from "./styles";

import { Switch, Route } from "react-router-dom";

import routes from "../../../routes";

const MainContent = () => {
  return (
    <Container>
      <Switch>
        {routes.map((route, i) => (
          <Route exact path={route.path} component={route.component} key={i} />
        ))}
      </Switch>
    </Container>
  );
};

export default MainContent;
