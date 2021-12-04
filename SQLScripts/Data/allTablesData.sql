INSERT INTO ct_category (cat_id, cat_name) VALUES (UUID_TO_BIN('96915ac2-5514-11ec-b894-9b023a1bdbf8'), 'C#');
INSERT INTO ct_category (cat_id, cat_name) VALUES (UUID_TO_BIN('96915b30-5514-11ec-b894-9b023a1bdbf8'), '.Net Core');
INSERT INTO ct_category (cat_id, cat_name) VALUES (UUID_TO_BIN('96915b3b-5514-11ec-b894-9b023a1bdbf8'), 'Data Structures');
INSERT INTO ct_category (cat_id, cat_name) VALUES (UUID_TO_BIN('96915b43-5514-11ec-b894-9b023a1bdbf8'), 'Algorithms');
INSERT INTO ct_category (cat_id, cat_name) VALUES (UUID_TO_BIN('96915b4a-5514-11ec-b894-9b023a1bdbf8'), 'DDD');
INSERT INTO ct_category (cat_id, cat_name) VALUES (UUID_TO_BIN('96915b51-5514-11ec-b894-9b023a1bdbf8'), 'OOPS');
INSERT INTO ct_category (cat_id, cat_name) VALUES (UUID_TO_BIN('96915b57-5514-11ec-b894-9b023a1bdbf8'), 'Others');

INSERT INTO ct_topic (top_id, top_name, top_top_id, top_cat_id) VALUES (UUID_TO_BIN('96915b5e-5514-11ec-b894-9b023a1bdbf8'), 'Covariance and Contravariance', NULL, UUID_TO_BIN('96915ac2-5514-11ec-b894-9b023a1bdbf8'));
INSERT INTO ct_topic (top_id, top_name, top_top_id, top_cat_id) VALUES (UUID_TO_BIN('96915b65-5514-11ec-b894-9b023a1bdbf8'), 'Channels in C#', NULL, UUID_TO_BIN('96915ac2-5514-11ec-b894-9b023a1bdbf8'));
INSERT INTO ct_topic (top_id, top_name, top_top_id, top_cat_id) VALUES (UUID_TO_BIN('96915b6b-5514-11ec-b894-9b023a1bdbf8'), 'HashTable', NULL, UUID_TO_BIN('96915b3b-5514-11ec-b894-9b023a1bdbf8'));
INSERT INTO ct_topic (top_id, top_name, top_top_id, top_cat_id) VALUES (UUID_TO_BIN('96915b72-5514-11ec-b894-9b023a1bdbf8'), 'Hash Function', UUID_TO_BIN('96915b6b-5514-11ec-b894-9b023a1bdbf8'), UUID_TO_BIN('96915b3b-5514-11ec-b894-9b023a1bdbf8'));
INSERT INTO ct_topic (top_id, top_name, top_top_id, top_cat_id) VALUES (UUID_TO_BIN('96915b79-5514-11ec-b894-9b023a1bdbf8'), 'Hash Collision', UUID_TO_BIN('96915b6b-5514-11ec-b894-9b023a1bdbf8'), UUID_TO_BIN('96915b3b-5514-11ec-b894-9b023a1bdbf8'));
INSERT INTO ct_topic (top_id, top_name, top_top_id, top_cat_id) VALUES (UUID_TO_BIN('96915b7f-5514-11ec-b894-9b023a1bdbf8'), 'Separate Chaining', UUID_TO_BIN('96915b79-5514-11ec-b894-9b023a1bdbf8'), UUID_TO_BIN('96915b3b-5514-11ec-b894-9b023a1bdbf8'));
INSERT INTO ct_topic (top_id, top_name, top_top_id, top_cat_id) VALUES (UUID_TO_BIN('fe18f6ed-5516-11ec-b894-9b023a1bdbf8'), 'Linear Probing', UUID_TO_BIN('96915b79-5514-11ec-b894-9b023a1bdbf8'), UUID_TO_BIN('96915b3b-5514-11ec-b894-9b023a1bdbf8'));
INSERT INTO ct_topic (top_id, top_name, top_top_id, top_cat_id) VALUES (UUID_TO_BIN('fe18f743-5516-11ec-b894-9b023a1bdbf8'), 'Quadratic Probing', UUID_TO_BIN('96915b79-5514-11ec-b894-9b023a1bdbf8'), UUID_TO_BIN('96915b3b-5514-11ec-b894-9b023a1bdbf8'));
INSERT INTO ct_topic (top_id, top_name, top_top_id, top_cat_id) VALUES (UUID_TO_BIN('fe18f753-5516-11ec-b894-9b023a1bdbf8'), 'Double Hashing', UUID_TO_BIN('96915b79-5514-11ec-b894-9b023a1bdbf8'), UUID_TO_BIN('96915b3b-5514-11ec-b894-9b023a1bdbf8'));
INSERT INTO ct_topic (top_id, top_name, top_top_id, top_cat_id) VALUES (UUID_TO_BIN('fe18f75d-5516-11ec-b894-9b023a1bdbf8'), 'Disjoint Set (Union-Find)', NULL, UUID_TO_BIN('96915b3b-5514-11ec-b894-9b023a1bdbf8'));
INSERT INTO ct_topic (top_id, top_name, top_top_id, top_cat_id) VALUES (UUID_TO_BIN('fe18f767-5516-11ec-b894-9b023a1bdbf8'), 'Stack', NULL, UUID_TO_BIN('96915b3b-5514-11ec-b894-9b023a1bdbf8'));
INSERT INTO ct_topic (top_id, top_name, top_top_id, top_cat_id) VALUES (UUID_TO_BIN('fe18f772-5516-11ec-b894-9b023a1bdbf8'), 'Queue', NULL, UUID_TO_BIN('96915b3b-5514-11ec-b894-9b023a1bdbf8'));
INSERT INTO ct_topic (top_id, top_name, top_top_id, top_cat_id) VALUES (UUID_TO_BIN('fe18f77c-5516-11ec-b894-9b023a1bdbf8'), 'Priority Queue', NULL, UUID_TO_BIN('96915b3b-5514-11ec-b894-9b023a1bdbf8'));
INSERT INTO ct_topic (top_id, top_name, top_top_id, top_cat_id) VALUES (UUID_TO_BIN('fe18f788-5516-11ec-b894-9b023a1bdbf8'), 'Binary Search Tree', NULL, UUID_TO_BIN('96915b3b-5514-11ec-b894-9b023a1bdbf8'));


