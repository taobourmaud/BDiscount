import { List, Datagrid, TextField, NumberField, DeleteButton, Create, SimpleForm, TextInput, NumberInput, Edit, ImageField, ImageInput } from 'react-admin';

export const ProductList = () => {
    return (
        <List>
            <Datagrid rowClick="edit">
              <NumberField source="id" />
              <TextField source="name" />
              <TextField source="description" />
              <NumberField source="price" />
              <ImageField source="image" />
              <TextField source="category" />
              <DeleteButton />
            </Datagrid>
        </List>
    )
}

export const ProductEdit = () => {
    return (
        <Edit>
            <SimpleForm>
                <NumberInput disabled source="id" />
                <TextInput source="name" />
                <TextInput source="description" />
                <NumberInput source="price" />
                <ImageInput source="image" />
                <TextInput source="category" />
            </SimpleForm>
        </Edit>
    )
}

export const ProductCreate = () => {
    return (
        <Create title='Create User'>
            <SimpleForm>
                <NumberInput source="id" />
                <TextInput source="name" />
                <TextInput source="description" />
                <NumberInput source="price" />
                <ImageInput source="image" />
                <TextInput source="category" />
            </SimpleForm>
        </Create>
    )
}