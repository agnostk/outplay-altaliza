import styled from "styled-components";

interface Props {
  bg: string;
}

export const Parallax = styled.div<Props>`
  background-image: linear-gradient(
      0deg,
      rgba(0, 0, 0, 0.8) 45%,
      rgba(255, 255, 255, 0) 100%
    ),
    url("${(props) => props.bg}");
  min-height: 400px;

  background-attachment: fixed;
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
`;

export const PageTitle = styled.div`
  padding-top: 300px;
`;
