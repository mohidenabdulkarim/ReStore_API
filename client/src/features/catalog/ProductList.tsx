import { Grid, List } from "@mui/material";
import React from "react";
import { Product } from "../../app/models";
import { ProductCard } from "./ProductCard";

type Props = {
  products: Product[];
};

export const ProductList: React.FC<Props> = ({ products }) => {
  return (
    // <Grid container columnGap={5} mt={10}>
    <Grid container spacing={4}>
      {products.map((p, idx) => (
        <Grid item key={idx} xs={12} sm={6} lg={3}>
          <ProductCard product={p} />
        </Grid>
      ))}
    </Grid>
  );
};
