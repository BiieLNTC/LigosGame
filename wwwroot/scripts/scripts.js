// Inicializar o tabuleiro do jogo
function initializeGameBoard() {
    // Adicionar listeners para redimensionamento
    window.addEventListener("resize", adjustLetterPositions)

    // Posicionar as letras inicialmente
    adjustLetterPositions()
}

// Ajustar posições das letras com base no tamanho da tela
function adjustLetterPositions() {
    const isMobile = window.innerWidth <= 768
    const isSmallMobile = window.innerWidth <= 480

    // Ajustar o raio com base no tamanho da tela
    const radius = isSmallMobile ? 120 : isMobile ? 150 : 180

    // Aplicar transformações CSS diretamente (opcional, já que você tem CSS para isso)
    // Isso é apenas para ajustes finos se necessário
}

// Versão simplificada do script para evitar erros

// Este arquivo é mantido para compatibilidade, mas não é necessário para o funcionamento básico
window.playSound = (soundType) => {
    console.log("Som reproduzido:", soundType)
    // Implementação futura
}

window.animateLetterSelection = (letterId) => {
    console.log("Animando letra:", letterId)
    // Implementação futura
}

// Expor funções para o Blazor
window.initializeGameBoard = initializeGameBoard
