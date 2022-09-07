import {
  Avatar,
  Button,
  List,
  ListItem,
  ListItemAvatar,
  ListItemText,
} from "@mui/material";
import React from "react";
import { Product } from "../../app/models";
import { ProductList } from "./ProductList";

type Props = {
  products: Product[];
};
export const Catalog: React.FC<Props> = ({ products }) => {
  return (
    <>
      <ProductList products={products} />
    </>
  );
};
