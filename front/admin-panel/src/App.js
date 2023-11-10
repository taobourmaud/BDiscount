import { Admin, Resource } from "react-admin";
import { ProductList, ProductEdit, ProductCreate } from './components/Products';
import restProvider from 'ra-data-simple-rest';

const dataProvider = restProvider('http://localhost:3000');
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