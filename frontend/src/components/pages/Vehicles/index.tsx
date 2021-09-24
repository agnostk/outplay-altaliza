import {
  Button,
  Card,
  CardBody,
  CardImg,
  CardSubtitle,
  CardTitle,
  Col,
  Container,
  Row,
} from "reactstrap";
import { PageTitle, Parallax } from "./styles";
import { FaCar } from "react-icons/fa";
import axios from "axios";
import { useEffect } from "react";

import React, { useState } from "react";

interface Vehicle {
  id: number;
  name: string;
  category: number;
  stock: number;
  image: string;
  price1Day: number;
  price7Days: number;
  price15Days: number;
}

const Vehicles = () => {
  const [vehicles, setVehicles] = useState<Vehicle[]>([]);
  useEffect(() => {
    const fetchData = async () => {
      const result = await axios("https://localhost:5001/vehicles");

      setVehicles(result.data);
    };
    fetchData();
  }, []);

  return (
    <>
      <Parallax bg="assets/vehicles-cover.jpg" className="m-0">
        <PageTitle>
          <h1 className="text-center text-white title">Veículos</h1>
        </PageTitle>
      </Parallax>
      <Container className="my-5">
        <Row className="mx-auto">
          {vehicles.map((vehicle) => (
            <Col xs="3" className="py-3">
              <Card key={vehicle.id}>
                <CardBody>
                  <div className="d-flex justify-content-between">
                    <CardTitle tag="h5">{vehicle.name}</CardTitle>
                    <span className="mt-1">
                      <FaCar />
                      <strong> 3 </strong>
                    </span>
                  </div>
                  <CardSubtitle tag="h6" className="mb-2 text-muted">
                    <strong> R$ {vehicle.price1Day} </strong>
                    <small> por dia </small>
                  </CardSubtitle>
                </CardBody>
                <CardImg src={"assets" + vehicle.image}></CardImg>
                <Button>Alugar</Button>
              </Card>
            </Col>
          ))}
        </Row>
      </Container>
    </>
  );
};

export default Vehicles;
