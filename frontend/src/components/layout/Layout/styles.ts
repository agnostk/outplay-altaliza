import styled from "styled-components";

//TB - TopBar
//MC - MainContent
//FB - FooterBar

export const Grid = styled.div`
  display: grid;

  grid-template-rows: 62px auto;
  grid-template-columns: auto;

  grid-template-areas:
    "TB"
    "MC"
    "FB";

  height: 100vh;
`;
