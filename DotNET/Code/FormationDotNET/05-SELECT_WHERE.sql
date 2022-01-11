-- Recupération de l'ensemble des valeurs présentes
SELECT * 
FROM PRODUCT pro

-- Requête sur la table PRODUCT avec des criteres de séléction
SELECT * 
FROM PRODUCT Pro
WHERE Pro.PRODUCT_TYPE_CD = 'LOAN'

SELECT * 
FROM PRODUCT Pro
WHERE Pro.PRODUCT_TYPE_CD = 'ACCOUNT'

-- Rechercher une entrée précise
SELECT Pro.PRODUCT_CD, Pro.NAME 
FROM PRODUCT Pro
WHERE Pro.NAME = 'auto loan'