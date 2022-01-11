-- La fonction Min() permet de retourner la plus grande valeur d'une colonne
select * from Account

-- Selection de la valeur maximale de la table ACCOUNT
SELECT Max(Acc.AVAIL_BALANCE) AS SoldeMax
FROM ACCOUNT Acc


-- Selection de la valeur maximale pour les comptes épargnes de la table ACCOUNT
SELECT Max(Acc.AVAIL_BALANCE) AS SoldeMax
FROM ACCOUNT Acc
WHERE Acc.PRODUCT_CD='SAV'

-- En utilisant GROUP BY
-- Les comptes sont dans plusieurs agences
-- Rechercher la valeur maximale des comptes pour chaque agence
SELECT Acc.OPEN_BRANCH_ID,
		Max(Acc.AVAIL_BALANCE) AS SoldeMax
FROM ACCOUNT Acc
GROUP BY Acc.OPEN_BRANCH_ID