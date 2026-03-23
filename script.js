// Function to handle orders via WhatsApp
function sendOrder(productName) {
    const phoneNumber = "46988283614"; // Replace with your actual number
    const message = `Hello Don Jacomossi! I want to order the: ${productName}`;
    const url = `https://wa.me/${phoneNumber}?text=${encodeURIComponent(message)}`;
    
    window.open(url, '_blank');
}

console.log("Jacomossi System Online. Deploying style...");