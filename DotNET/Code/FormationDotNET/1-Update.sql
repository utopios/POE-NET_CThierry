-- Affichage de la table Account
SELECT * FROM ACCOUNT


-- Affichage d'un compte (N° 1) de la table Account
SELECT Acc.ACCOUNT_ID,
		Acc.PRODUCT_CD,
		Acc.AVAIL_BALANCE,
		Acc.PENDING_BALANCE,
		Acc.CUST_ID
FROM ACCOUNT Acc
WHERE Acc.CUST_ID = 1

---- Update les compte pour le client 1 avec une augmentation de 5%
--UPDATE ACCOUNT
--SET AVAIL_BALANCE = AVAIL_BALANCE + 5*AVAIL_BALANCE/100,
--    PENDING_BALANCE = PENDING_BALANCE + 5*PENDING_BALANCE/100
--WHERE CUST_ID = 1

-- Update les compte pour le client 1 avec une augmentation de 5%
UPDATE ACCOUNT
SET AVAIL_BALANCE = AVAIL_BALANCE*100/105,
    PENDING_BALANCE = PENDING_BALANCE*100/105
WHERE CUST_ID = 1

-- Affichage d'un compte (N° 1) de la table Account
SELECT Acc.ACCOUNT_ID,
		Acc.PRODUCT_CD,
		Acc.AVAIL_BALANCE,
		Acc.PENDING_BALANCE,
		Acc.CUST_ID
FROM ACCOUNT Acc
WHERE Acc.CUST_ID = 1