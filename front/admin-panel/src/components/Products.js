import { List, Datagrid, TextField, NumberField, DeleteButton, Create, SimpleForm, TextInput, NumberInput, Edit, ImageField, ImageInput } from 'react-admin';
// import  { Product } from "../../../src/models/product.model";
// import { useEffect, useState } from "react";
// import { CreateProduct } from "../../../src/requests/product";

export const ProductList = () => {
    return (
        <List>
            <Datagrid rowClick="edit">
              <NumberField source="id" />
              <TextField source="name" />
              <TextField source="description" />
              <NumberField source="price" />
              <ImageField source="image" />
              <NumberField source="category" />
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
                <NumberInput source="category" />
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
                <NumberInput source="category" />
            </SimpleForm>
        </Create>
    )
}