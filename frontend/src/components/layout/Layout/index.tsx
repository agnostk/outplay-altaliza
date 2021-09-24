import MainContent from "../MainContent";
import Topbar from "../Topbar";
import { Grid } from "./styles";

const Layout = () => {
  return (
    <Grid>
      <Topbar />
      <MainContent />
    </Grid>
  );
};

export default Layout;
