function weddingInvestment(periodContract, typeContract, desert, numberMonths) {
    let monthTax = 0;

    if (periodContract === "one") {
        if (typeContract === "Small") {
            monthTax = 9.98;
        } else if (typeContract === "Middle") {
            monthTax = 18.99;
        } else if (typeContract === "Large") {
            monthTax = 25.98;
        } else if (typeContract === "ExtraLarge") {
            monthTax = 35.99;
        }
    } else {
        if (typeContract === "Small") {
            monthTax = 8.58;
        } else if (typeContract === "Middle") {
            monthTax = 17.09;
        } else if (typeContract === "Large") {
            monthTax = 23.59;
        } else if (typeContract === "ExtraLarge") {
            monthTax = 31.79;
        }
    }

    if (desert === "yes") {
        if (monthTax > 30) {
            monthTax += 3.85;
        } else if (monthTax > 10) {
            monthTax += 4.35;
        } else {
            monthTax += 5.5;
        }
    }

    let finalSum = numberMonths * monthTax;

    if (periodContract === "two") {
        finalSum = finalSum - finalSum * 0.0375;
    }

    console.log(`${finalSum.toFixed(2)} lv.`);
}