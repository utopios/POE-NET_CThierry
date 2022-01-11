-- Affichage de la table ACC_Transaction
SELECT * FROM ACC_TRANSACTION
ORDER BY TXN_ID DESC

-- Suppression des entres avec "in" (permet suppression multiple)
DELETE FROM ACC_TRANSACTION
WHERE TXN_ID in (26,28)


-- Suppression des entres avec "Between" (permet suppression multiple)
DELETE FROM ACC_TRANSACTION
WHERE TXN_ID 
BETWEEN 22
AND 25

-- Suppression des entres avec "in" (permet suppression multiple)
DELETE FROM ACC_TRANSACTION
WHERE TXN_ID=27