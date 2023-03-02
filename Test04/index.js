const faturamento = [
    { estado: "SP", valor: 67836.43},
    { estado: "RJ", valor: 36678.66},
    { estado: "MG", valor: 29229.88},
    { estado: "ES", valor: 27165.48},
    { estado: "Outros", valor: 19849.53}

]



const porcentagem = function (faturamento) {

    let soma = faturamento.reduce(function(acumulador, valorAtual){
        return acumulador + valorAtual.valor;
    }, 0)

    for (let i = 0; i < faturamento.length; i++) {
        let percentual = (faturamento[i].valor / soma) * 100;
        faturamento[i].percentual = percentual.toFixed(2) + "%"; 
    }
    return faturamento;
}


console.log(porcentagem(faturamento))