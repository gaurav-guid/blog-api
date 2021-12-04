CREATE TABLE IF NOT EXISTS ct_category
(
	cat_id BINARY(16) PRIMARY KEY DEFAULT (UUID_TO_BIN(UUID())),
    cat_name VARCHAR(256) NOT NULL UNIQUE,
    cat_created DATETIME NOT NULL DEFAULT NOW(),
    cat_lastModified DATETIME
);

CREATE TABLE IF NOT EXISTS ct_topic
(
	top_id BINARY(16) PRIMARY KEY DEFAULT (UUID_TO_BIN(UUID())),
    top_name VARCHAR(512) NOT NULL UNIQUE,
    top_top_id BINARY(16) REFERENCES ct_topic (top_id),
    top_cat_id BINARY(16) REFERENCES ct_category (cat_id),
    top_created DATETIME NOT NULL DEFAULT NOW(),
    top_lastModified DATETIME
);