// Produkt-interface
interface Product {
  name: string;
  price: number;
  getDetails(): string;
}


class Book implements Product {
  constructor(
    public name: string, 
    public price: number, 
    private author: string
  ) {}

  getDetails(): string {
    return `Bok: ${this.name}, Författare: ${this.author}`;
  }
}

class Electronics implements Product {
  constructor(
    public name: string, 
    public price: number, 
    private brand: string
  ) {}

  getDetails(): string {
    return `Elektronik: ${this.name}, Märke: ${this.brand}`;
  }
}

const createProduct = (
  type: "book" | "electronics",
  name: string,
  price: number,
  extra: string
): Product => {
  switch (type) {
    case "book":
      return new Book(name, price, extra);
    case "electronics":
      return new Electronics(name, price, extra);
    default:
      throw new Error("Ogiltig produkttyp");
  }
};

// use .!
const book = createProduct("book", "Sagan om ringen", 299, "J.R.R. Tolkien");
console.log(book.getDetails()); // "Bok: Sagan om ringen, Författare: J.R.R. Tolkien"
