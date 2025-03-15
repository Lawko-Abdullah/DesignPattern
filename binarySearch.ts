const binarySearch = (products: Product[], targetId: number): Product | null => {
  let left = 0;
  let right = products.length - 1;

  while (left <= right) {
    const mid = Math.floor((left + right) / 2);
    if (products[mid].id === targetId) return products[mid];
    if (products[mid].id < targetId) left = mid + 1;
    else right = mid - 1;
  }
  return null;
};

// Användning
const sortedProducts = [...]; 
const product = binarySearch(sortedProducts, 42);
