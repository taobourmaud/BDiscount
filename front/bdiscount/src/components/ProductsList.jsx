// ProductsList.js
import React, { useEffect, useState } from 'react';
import { Card, Container, Row, Col } from 'react-bootstrap';
import 'bootstrap/dist/css/bootstrap.min.css';
import data from '../db.json';

const ProductsList = () => {
  const [products, setProducts] = useState([]);

  useEffect(() => {
    // Charger les données depuis le fichier JSON
    fetch(data)  // Assurez-vous que le chemin est correct
      .then(response => response.json())
      .then(data => setProducts(data.products))
      .catch(error => console.error('Error fetching data:', error));
  }, []);

  return (
    <Container>
      <Row>
        {products.map(product => (
          <Col key={product.id} md={4}>
            <Card>
              <Card.Img variant="top" src={product.image.src || 'placeholder_image_url'} alt={product.name} />
              <Card.Body>
                <Card.Title>{product.name}</Card.Title>
                <Card.Text>{product.description}</Card.Text>
                <Card.Text>Price: ${product.price}</Card.Text>
              </Card.Body>
            </Card>
          </Col>
        ))}
      </Row>
    </Container>
  );
};

export default ProductsList;
