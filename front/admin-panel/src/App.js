import { Admin, Resource } from "react-admin";
import { UserList, UserEdit, UserCreate } from './components/User';
import restProvider from 'ra-data-simple-rest';

const dataProvider = restProvider('http://localhost:3000');
function App() {
  return (
      <Admin dataProvider={dataProvider}>
        <Resource
          name="users"
          list={UserList}
          edit={UserEdit}
          create={UserCreate}
        />
      </Admin>
    );
  }
export default App;