import { calculateCartTotal } from "./cartCalculator.js";

const cart = [
  { name: "Laptop", price: 800, quantity: 1 },
  { name: "Mouse", price: 25, quantity: 2 },
  { name: "Keyboard", price: 50, quantity: 1 }
];

const total = calculateCartTotal(cart);

const invoice = `

${cart
  .map(
    product =>
      `${product.name} - $${product.price} x ${product.quantity} = $${product.price * product.quantity}`
  )
  .join("\n")}


Total Amount: $${total}
`;

console.log(invoice);