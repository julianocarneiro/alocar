import type { Metadata } from 'next'
import { Inter } from 'next/font/google'
import '../styles';
import PageContainer from '@/components/Page/PageContainer';

const inter = Inter({ subsets: ['latin'] })

export const metadata: Metadata = {
    title: 'Alocar',
    description: 'Sistema de Locação de Veiculos',
}

export default function RootLayout({
    children,
}: {
    children: React.ReactNode
}) {
    return (
        <html lang="en">
            <body className={inter.className}>

                <PageContainer title="">
                    {children}
                </PageContainer>
            
            </body>
        </html>
    )
}
