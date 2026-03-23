/* Lil Peep x Jacomossi Floating Aesthetic */
body {
    background: linear-gradient(45deg, #0a0a0a, #1a0a1a); /* Deep moody purple/black */
    color: #fff;
    font-family: 'Helvetica Neue', sans-serif;
    overflow-x: hidden;
}

header {
    height: 100vh;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    animation: float 6s ease-in-out infinite; /* The "Floating" effect */
}

.logo {
    font-size: 5rem;
    text-shadow: 0 0 20px rgba(255, 255, 255, 0.5);
    letter-spacing: 15px;
}

.card {
    background: rgba(255, 255, 255, 0.05); /* Glass effect */
    backdrop-filter: blur(10px); /* Blurry background */
    border: 1px solid rgba(255, 255, 255, 0.1);
    border-radius: 20px;
    padding: 30px;
    transition: 0.5s cubic-bezier(0.175, 0.885, 0.32, 1.275);
}

.card:hover {
    transform: translateY(-20px) scale(1.05);
    box-shadow: 0 20px 40px rgba(0,0,0,0.8);
    border-color: #ff0055; /* Peep's signature pink/red accent */
}

/* Floating Animation Code */
@keyframes float {
    0% { transform: translateY(0px); }
    50% { transform: translateY(-20px); }
    100% { transform: translateY(0px); }
}

.btn-order {
    background: transparent;
    border: 2px solid #fff;
    color: #fff;
    padding: 15px 30px;
    border-radius: 50px;
    transition: 0.3s;
}

.btn-order:hover {
    background: #fff;
    color: #000;
}