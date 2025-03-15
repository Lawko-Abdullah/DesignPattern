const quickSort = (products: Product[]): Product[] => {
  if (products.length <= 1) return products;

  const pivot = products[Math.floor(products.length / 2)];
  const left: Product[] = [];
  const right: Product[] = [];

  for (const product of products) {
    if (product.price < pivot.price) left.push(product);
    else if (product.price > pivot.price) right.push(product);
  }

  return [...quickSort(left), pivot, ...quickSort(right)];
};

// Användning
const unsortedProducts = [...];
const sortedByPrice = quickSort(unsortedProducts);
