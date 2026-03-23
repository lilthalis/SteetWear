/* Minimalist Dark Theme */
body {
    background-color: #050505;
    color: #ffffff;
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    margin: 0;
    line-height: 1.6;
}

header {
    height: 60vh;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    border-bottom: 1px solid #1a1a1a;
}

.logo {
    font-size: 4rem;
    letter-spacing: 12px;
    margin: 0;
}

.subtitle {
    color: #888;
    text-transform: uppercase;
    font-size: 0.9rem;
}

.container {
    max-width: 1100px;
    margin: auto;
    padding: 40px 20px;
}

.product-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(280px, 1fr));
    gap: 30px;
}

.card {
    background: #0a0a0a;
    border: 1px solid #1a1a1a;
    padding: 20px;
    text-align: center;
    transition: 0.4s ease;
}

.card:hover {
    border-color: #ffd700; /* Gold accent */
    transform: translateY(-10px);
}

.image-placeholder {
    background: #111;
    height: 300px;
    margin-bottom: 15px;
}

.btn-order {
    background: #fff;
    color: #000;
    border: none;
    padding: 12px 25px;
    font-weight: bold;
    cursor: pointer;
    text-transform: uppercase;
}

.btn-order:hover {
    background: #ffd700;
}