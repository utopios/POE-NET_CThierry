-- Affichage de la table ACCOUNT
SELECT * FROM ACCOUNT

-- Calculer la moyenne des comptes épargne (SAV)
SELECT AVG(Acc.AVAIL_BALANCE) AS MoyenneComptesEpargne
FROM ACCOUNT Acc
WHERE Acc.PRODUCT_CD='SAV'

-- En utilisant le Group By
-- Un client possede un ou plusieur comptes
-- Calcul de la moyenne des comptes pour chaque client de l'agence( OPEN_BRANCHE_ID =1)
SELECT Acc.CUST_ID,
		AVG(Acc.AVAIL_BALANCE) AS MoyenneComptesEpargne
FROM ACCOUNT Acc
WHERE Acc.OPEN_BRANCH_ID=1
GROUP BY Acc.CUST_ID