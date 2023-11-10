import { List, Datagrid, TextField, EmailField, DeleteButton, Create, SimpleForm, TextInput, NumberInput, Edit } from 'react-admin';

export const UserList = () => {
    return (
        <List>
            <Datagrid rowClick="edit">
              <TextField source="id" />
              <TextField source="name" />
              <TextField source="username" />
              <EmailField source="email" />
              <TextField source="phone" />
              <TextField source="company" />
              <DeleteButton />
            </Datagrid>
        </List>
    )
}

export const UserEdit = () => {
    return (
        <Edit>
            <SimpleForm>
                <TextInput disabled source="id" />
                <TextInput source="name" />
                <TextInput source="username" />
                <TextInput source="email" />
                <TextInput source="phone" />
                <TextInput source="company"/>
            </SimpleForm>
        </Edit>
    )
}

export const UserCreate = () => {
    return (
        <Create title='Create User'>
            <SimpleForm>
                <NumberInput source="id" />
                <TextInput source="name" />
                <TextInput source="username" />
                <TextInput source="email" />
                <TextInput source="phone" />
                <TextInput source="company"/>
            </SimpleForm>
        </Create>
    )
}