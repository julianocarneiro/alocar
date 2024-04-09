'use client'

import Link from "next/link";
import styles from "./Header.module.css";
import classNames from "classnames";

type HeaderProps = {
    title: string;
    fixHeader?: boolean;
    borderBotton?: boolean;
    url?: string;
};

export default function Header({
    title,
    fixHeader = true,
    borderBotton = false,
    url,
}: HeaderProps) {
    return (
        <>
        <div className={classNames({[styles.header]: true, [styles.fixHeader]: fixHeader, [styles.borderBotton]:borderBotton })}>
            Alocar
        </div>
        </>
    )
}

