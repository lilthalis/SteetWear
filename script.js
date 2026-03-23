function openLegacy(albumName) {
    alert("Welcome to the history of: " + albumName + ". The Jacomossi vibe is real.");
}

function sendOrder(item) {
    const msg = `Yo Don! I want that custom ${item}. Check my size!`;
    window.open(`https://wa.me/5546988283614?text=${encodeURIComponent(msg)}`, '_blank');
}