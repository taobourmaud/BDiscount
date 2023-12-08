import React, { useState, useRef, useEffect } from 'react';
import { Admin, Resource } from "react-admin";
import { ProductList, ProductEdit, ProductCreate } from './components/Products';
// import { ReactKeycloakProvider } from "@react-keycloak/web";
// import { keycloakAuthProvider, httpClient } from 'ra-keycloak';
// import keycloakClient from "./Keycloak";
// import Keycloak from 'keycloak-js';
import simpleRestProvider from 'ra-data-simple-rest';

// const config = {
//   url: "http://localhost:8080",
//   realm: "bdiscount",
//   clientId: "panel_admin",
// };

// const initOptions = { onLoad: 'login-required' };

// const getPermissions = (decoded) => {
//   const roles = decoded?.realm_access?.roles;
//   if (!roles) {
//       return false;
//   }
//   if (roles.includes('admin')) return 'admin';
//   if (roles.includes('user')) return 'user';
//   return false;
// };

// const raKeycloakOptions = {
//   onPermissions: getPermissions,
// };


// const App = () => {
//   const [keycloak, setKeycloak] = useState(undefined);
//   const authProvider = useRef(undefined);
//   const dataProvider = useRef(undefined);

//   useEffect(() => {
//     const initKeyCloakClient = async () => {
//         const keycloakClient = new Keycloak(config);
//         await keycloakClient.init(initOptions);
//         authProvider.current = keycloakAuthProvider(
//             keycloakClient,
//             raKeycloakOptions
//         );
//         dataProvider.current = simpleRestProvider(
//             'http://localhost:5000',
//             httpClient(keycloakClient)
//         );
//         setKeycloak(keycloakClient);
//     };
//     if (!keycloak) {
//         initKeyCloakClient();
//     }
//   }, [keycloak]);

//   if (!keycloak) return <p>Loading...</p>;


//   return (
//     <Admin authProvider={authProvider.current} dataProvider={dataProvider.current}>
//       <Resource
//         name='products'
//         list={ProductList}
//         edit={ProductEdit}
//         create={ProductCreate}
//       />
//     </Admin>
//   );
// };

const dataProvider = simpleRestProvider('http://localhost:3000');
function App() {
  return (
    <Admin dataProvider={dataProvider}>
      <Resource
        name="products"
        list={ProductList}
        edit={ProductEdit}
        create={ProductCreate}
      />
    </Admin>
    );
  }
export default App;
