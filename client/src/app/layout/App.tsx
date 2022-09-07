import {
  Container,
  createTheme,
  CssBaseline,
  ThemeProvider,
} from "@mui/material";
import React, { useEffect, useState } from "react";
import { Catalog } from "../../features";
import { Product } from "../models/product";
import { Header } from "./Header";

function App() {
  const [products, setProducts] = useState<Product[]>([]);
  const [darkMode, setDarkMode] = useState(false);
  const paletteType = darkMode ? "dark" : "light";

  const theme = createTheme({
    palette: {
      mode: paletteType,
      background: {
        default: paletteType === "light" ? "#eaeaea" : "#121212 ",
      },
    },
  });

  function handleThemeChange() {
    setDarkMode(!darkMode);
  }
  useEffect(() => {
    fetch("https://localhost:5001/api/Products")
      .then((response) => response.json())
      .then((data) => setProducts(data));
  }, []);

  return (
    <ThemeProvider theme={theme}>
      <CssBaseline />
      <Header darkMode={darkMode} handleThemeChange={handleThemeChange} />
      <Container sx={{ mt: 15 }}>
        <Catalog products={products} />
      </Container>
    </ThemeProvider>
  );
}

export default App;
