"use client";
import { ReactNode, useCallback, useEffect, useState } from "react";
import Header from "../Header";
import Sidebar from "../Sidebar";
import Footer from "../Footer";

interface PageProps {
    title: string;
    fixHeader?: boolean;
    children?: ReactNode;
    borderBotton?: boolean;
    url?: string;
  }

export default function PageContainer({
    title,
    fixHeader,
    children,
    borderBotton,
    url,
  }: PageProps)
{
    return (
        <div className="page-container">
            <Header 
                title={title}
                fixHeader={fixHeader}
                borderBotton={borderBotton}
                url={url}
            />
            <Sidebar />
            {children}
            <Footer />
        </div>
      );
}
