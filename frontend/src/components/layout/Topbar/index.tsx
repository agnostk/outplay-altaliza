import { Link, NavLink as RRNavLink } from "react-router-dom";
import { Nav, Navbar, NavbarBrand, NavItem, NavLink } from "reactstrap";
import { Container } from "./styles";

import routes from "../../../routes";

const Topbar = () => {
  return (
    <Container>
      <Navbar fixed="top" color="dark" dark expand className="px-4">
        <NavbarBrand tag={Link} to="/">
          <img
            src="assets/altaliza-brand.svg"
            width="218"
            height="46"
            alt="Altaliza Logo"
          />
        </NavbarBrand>
        <Nav className="mr-auto" navbar>
          {routes.map((route, i) => (
            <NavItem key={route.id}>
              <NavLink tag={RRNavLink} exact to={route.path}>
                {route.name}
              </NavLink>
            </NavItem>
          ))}
        </Nav>
      </Navbar>
    </Container>
  );
};

export default Topbar;
