<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="reponse PREND_LA_VALEUR &quot;Le nombre &quot; + nbUtil + &quot; n'est pas divisible par &quot; +diviseur" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2defaut="" F2etat="inactif" F2lignes="" F2para=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalAffichages="1000" epaisseurLigne="2" nbDecimales="8" maxBoucle="500000" epaisseurPoint="2" arrondiAuto="vrai" totalBoucles="5000000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="nbUtil EST_DU_TYPE NOMBRE" code="1#NOMBRE#nbUtil"/>
        <item algoitem="reponse EST_DU_TYPE CHAINE" code="1#CHAINE#reponse"/>
        <item algoitem="diviseur EST_DU_TYPE NOMBRE" code="1#NOMBRE#diviseur"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Veuillez saisir un nombre : &quot;" code="4#Veuillez saisir un nombre : #0"/>
        <item algoitem="LIRE nbUtil" code="2#nbUtil#pasliste"/>
        <item algoitem="AFFICHER &quot;Veuillez saisir le diviseur&quot;" code="4#Veuillez saisir le diviseur#0"/>
        <item algoitem="LIRE diviseur" code="2#diviseur#pasliste"/>
        <item algoitem="SI (nbUtil%diviseur==0) ALORS" code="6#nbUtil%diviseur==0">
            <item algoitem="DEBUT_SI" code="7#debutsi"/>
            <item algoitem="reponse PREND_LA_VALEUR &quot;Le nombre &quot; + nbUtil + &quot; est divisible par &quot; +diviseur" code="5#reponse#&quot;Le nombre &quot; + nbUtil + &quot; est divisible par &quot; +diviseur#pasliste"/>
            <item algoitem="AFFICHER reponse" code="3#reponse#0#pasliste"/>
            <item algoitem="FIN_SI" code="8#finsi"/>
            <item algoitem="SINON" code="9#sinon">
                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                <item algoitem="reponse PREND_LA_VALEUR &quot;Le nombre &quot; + nbUtil + &quot; n'est pas divisible par &quot; +diviseur" code="5#reponse#&quot;Le nombre &quot; + nbUtil + &quot; n'est pas divisible par &quot; +diviseur#pasliste"/>
                <item algoitem="AFFICHER reponse" code="3#reponse#0#pasliste"/>
                <item algoitem="FIN_SINON" code="11#finsinon"/>
            </item>
        </item>
        <item algoitem="" code="103#commentaire"/>
        <item algoitem="" code="103#commentaire"/>
        <item algoitem="" code="103#commentaire"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
