import { Admin, Resource } from "react-admin";
import { ProductList, ProductEdit, ProductCreate } from './components/Products';
import restProvider from 'ra-data-simple-rest';
import { ReactKeycloakProvider } from "@react-keycloak/web";
import keycloakClient from "./components/Keycloak";

const dataProvider = restProvider('http://localhost:3000');
function App() {
  return (
    <ReactKeycloakProvider authClient={keycloakClient}>
      <Admin dataProvider={dataProvider}>
        <Resource
          name="products"
          list={ProductList}
          edit={ProductEdit}
          create={ProductCreate}
        />
      </Admin>
    </ReactKeycloakProvider>
    );
  }
export default App;