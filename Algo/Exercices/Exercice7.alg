<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="reponse PREND_LA_VALEUR &quot;Mais ce n'est plus enfant!!!&quot;"/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2defaut="" F2para="" F2lignes="" F2etat="inactif"/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param nbDecimales="8" totalBoucles="5000000" totalAffichages="1000" arrondiAuto="vrai" epaisseurLigne="2" epaisseurPoint="2" maxBoucle="500000"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#age" algoitem="age EST_DU_TYPE NOMBRE"/>
        <item code="1#CHAINE#reponse" algoitem="reponse EST_DU_TYPE CHAINE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4#Veuillez indiquer l'age de votre enfant#0" algoitem="AFFICHER &quot;Veuillez indiquer l'age de votre enfant&quot;"/>
        <item code="2#age#pasliste" algoitem="LIRE age"/>
        <item code="6#age&lt;3" algoitem="SI (age&lt;3) ALORS">
            <item code="7#debutsi" algoitem="DEBUT_SI"/>
            <item code="5#reponse#&quot;Votre enfant est trop jeune pour pratiquer&quot;#pasliste" algoitem="reponse PREND_LA_VALEUR &quot;Votre enfant est trop jeune pour pratiquer&quot;"/>
            <item code="8#finsi" algoitem="FIN_SI"/>
            <item code="9#sinon" algoitem="SINON">
                <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                <item code="6#age>=3 et age &lt;= 6" algoitem="SI (age>=3 et age &lt;= 6) ALORS">
                    <item code="7#debutsi" algoitem="DEBUT_SI"/>
                    <item code="5#reponse#&quot;Votre enfant est dans la catégorie BABY&quot;#pasliste" algoitem="reponse PREND_LA_VALEUR &quot;Votre enfant est dans la catégorie BABY&quot;"/>
                    <item code="8#finsi" algoitem="FIN_SI"/>
                    <item code="9#sinon" algoitem="SINON">
                        <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                        <item code="6#age ==7 ou age ==8" algoitem="SI (age ==7 ou age ==8) ALORS">
                            <item code="7#debutsi" algoitem="DEBUT_SI"/>
                            <item code="5#reponse#&quot;Votre enfant est dans la catégorie poussin&quot;#pasliste" algoitem="reponse PREND_LA_VALEUR &quot;Votre enfant est dans la catégorie poussin&quot;"/>
                            <item code="8#finsi" algoitem="FIN_SI"/>
                            <item code="9#sinon" algoitem="SINON">
                                <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                                <item code="6#age == 9 ou age == 10" algoitem="SI (age == 9 ou age == 10) ALORS">
                                    <item code="7#debutsi" algoitem="DEBUT_SI"/>
                                    <item code="5#reponse#&quot;Votre enfant est dans la catégorie PUPILLE&quot;#pasliste" algoitem="reponse PREND_LA_VALEUR &quot;Votre enfant est dans la catégorie PUPILLE&quot;"/>
                                    <item code="8#finsi" algoitem="FIN_SI"/>
                                    <item code="9#sinon" algoitem="SINON">
                                        <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                                        <item code="6#age == 11 ou age == 12" algoitem="SI (age == 11 ou age == 12) ALORS">
                                            <item code="7#debutsi" algoitem="DEBUT_SI"/>
                                            <item code="5#reponse#&quot;Votre enfant est dans la catégorie Minime&quot;#pasliste" algoitem="reponse PREND_LA_VALEUR &quot;Votre enfant est dans la catégorie Minime&quot;"/>
                                            <item code="8#finsi" algoitem="FIN_SI"/>
                                            <item code="9#sinon" algoitem="SINON">
                                                <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                                                <item code="6#age >=13  ET age &lt;18" algoitem="SI (age >=13  ET age &lt;18) ALORS">
                                                    <item code="7#debutsi" algoitem="DEBUT_SI"/>
                                                    <item code="5#reponse#&quot;Votre enfant est dans la catégorie CADET&quot;#pasliste" algoitem="reponse PREND_LA_VALEUR &quot;Votre enfant est dans la catégorie CADET&quot;"/>
                                                    <item code="8#finsi" algoitem="FIN_SI"/>
                                                    <item code="9#sinon" algoitem="SINON">
                                                        <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                                                        <item code="5#reponse#&quot;Mais ce n'est plus enfant!!!&quot;#pasliste" algoitem="reponse PREND_LA_VALEUR &quot;Mais ce n'est plus enfant!!!&quot;"/>
                                                        <item code="11#finsinon" algoitem="FIN_SINON"/>
                                                    </item>
                                                </item>
                                                <item code="11#finsinon" algoitem="FIN_SINON"/>
                                            </item>
                                        </item>
                                        <item code="11#finsinon" algoitem="FIN_SINON"/>
                                    </item>
                                </item>
                                <item code="11#finsinon" algoitem="FIN_SINON"/>
                            </item>
                        </item>
                        <item code="11#finsinon" algoitem="FIN_SINON"/>
                    </item>
                </item>
                <item code="11#finsinon" algoitem="FIN_SINON"/>
            </item>
        </item>
        <item code="3#reponse#0#pasliste" algoitem="AFFICHER reponse"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
