<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="FIN_SINON" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2defaut="" F2para="" F2etat="inactif" F2lignes=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param epaisseurPoint="2" epaisseurLigne="2" maxBoucle="500000" arrondiAuto="vrai" totalAffichages="1000" totalBoucles="5000000" nbDecimales="8"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="Taille EST_DU_TYPE NOMBRE" code="1#NOMBRE#Taille"/>
        <item algoitem="Poids EST_DU_TYPE NOMBRE" code="1#NOMBRE#Poids"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Veuillez saisir votre taille (en cm)&quot;" code="4#Veuillez saisir votre taille (en cm)#0"/>
        <item algoitem="LIRE Taille" code="2#Taille#pasliste"/>
        <item algoitem="AFFICHER &quot;Veuillez saisir votre poids (en kg)&quot;" code="4#Veuillez saisir votre poids (en kg)#0"/>
        <item algoitem="LIRE Poids" code="2#Poids#pasliste"/>
        <item algoitem="SI (Taille>=145 ET Taille&lt;=171 ET Poids>=43 ET Poids&lt;=47 OU Taille>=145 ET Taille&lt;=168 ET Poids>=48 ET Poids&lt;=53 OU Taille>=145 ET Taille&lt;=165 ET Poids>=54 ET Poids&lt;=59 OU Taille>=145 ET Taille&lt;=162 ET Poids>=60 ET Poids&lt;=65) ALORS" code="6#Taille>=145 ET Taille&lt;=171 ET Poids>=43 ET Poids&lt;=47 OU Taille>=145 ET Taille&lt;=168 ET Poids>=48 ET Poids&lt;=53 OU Taille>=145 ET Taille&lt;=165 ET Poids>=54 ET Poids&lt;=59 OU Taille>=145 ET Taille&lt;=162 ET Poids>=60 ET Poids&lt;=65">
            <item algoitem="DEBUT_SI" code="7#debutsi"/>
            <item algoitem="AFFICHER &quot;Prennez la taille 1&quot;" code="4#Prennez la taille 1#0"/>
            <item algoitem="FIN_SI" code="8#finsi"/>
            <item algoitem="SINON" code="9#sinon">
                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                <item algoitem="AFFICHER &quot;Aucune taille ne vous correspond!&quot;" code="4#Aucune taille ne vous correspond!#0"/>
                <item algoitem="FIN_SINON" code="11#finsinon"/>
            </item>
        </item>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
